import java.util.concurrent.TimeUnit;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
public class PricesLock implements Runnable {
    private final Vehicle vehicle;
    private final ReentrantLock lock;

    public PricesLock(Vehicle vehicle, ReentrantLock lock) {
        this.vehicle = vehicle;
        this.lock = lock;
    }

    @Override
    public void run() {
        lock.lock();
        try {
            System.out.println("Цены: ");
            for (double v : vehicle.getPrices())
                System.out.println(v);
        }
        finally {
            lock.unlock();
        }
    }
}
