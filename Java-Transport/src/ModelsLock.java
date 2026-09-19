import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
public class ModelsLock implements Runnable{
    private final Vehicle vehicle;
    private final ReentrantLock lock;

    public ModelsLock(Vehicle vehicle, ReentrantLock lock) {
        this.vehicle = vehicle;
        this.lock = lock;
    }

    @Override
    public void run() {
        lock.lock();
        try {
            System.out.println("Модели: ");
            for(String v: vehicle.getArrayModels())
                System.out.println(v);
        }
        finally {
            lock.unlock();
        }
    }
}
