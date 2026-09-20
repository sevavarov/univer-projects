import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;

public class ServerThread implements Runnable{
    private static ObjectInputStream in;
    private static ObjectOutputStream out;
    private final Socket clientSocket;

    public ServerThread(Socket clientSocket) {
        this.clientSocket = clientSocket;
    }
    @Override
    public void run() {
        try {
            in = new ObjectInputStream(clientSocket.getInputStream());
            Vehicle[] vehicles = (Vehicle[]) in.readObject();
            double sum = 0;
            int count = 0;
            for (Vehicle v : vehicles) {
                double[] prices = v.getPrices();
                for (int i = 0; i < v.getSize(); i++) {
                    sum += prices[i];
                    count++;
                }
            }
            out = new ObjectOutputStream(clientSocket.getOutputStream());
            out.writeDouble(sum/count);
            out.flush();
            in.close();
            out.close();
            clientSocket.close();
        }catch (Exception e) {
            e.printStackTrace();
        }

    }
}
