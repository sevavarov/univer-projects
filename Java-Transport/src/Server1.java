import java.io.IOException;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class Server1 {
    private static Socket clientSocket;
    private static ServerSocket server;
    private static ObjectInputStream in;

    public static void main(String[] args) {
            try {
                server = new ServerSocket(1);
//                while (true) {
                    clientSocket = server.accept();
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
//                    }
                    ObjectOutputStream out = new ObjectOutputStream(clientSocket.getOutputStream());
                    out.writeDouble(sum/count);
                    out.flush();
                    in.close();
                    out.close();
                    clientSocket.close();
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

