import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;

public class BrandQueue implements Runnable{
    private final String fileName;
    private ArrayBlockingQueue<String> block;

    public BrandQueue(String fileName, ArrayBlockingQueue<String> block) {
        this.block = block;
        this.fileName = fileName;
    }
    @Override
    public void run() {
        try {
            BufferedReader reader = new BufferedReader(new FileReader(fileName));
            Vehicle vehicle = new Car(reader.readLine(), 0);
            block.put(vehicle.getBrand());
        } catch (IOException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
    }
}
