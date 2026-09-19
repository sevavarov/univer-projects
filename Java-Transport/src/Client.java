import java.io.*;
import java.net.Socket;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class Client {
    public static void main(String[] args) {
            try {
                Socket clientSocket = new Socket("localhost", 1);
                Vehicle[] vehicles = new Vehicle[]{new Car("Lamborgini", 4), new Bike("Racer", 3), new Car("Ferrary", 5)};
                ObjectOutputStream out = new ObjectOutputStream(clientSocket.getOutputStream());
                out.writeObject(vehicles);
                ObjectInputStream in = new ObjectInputStream(clientSocket.getInputStream());
                double sredArifm = in.readDouble();
                System.out.println("Среднее арифметическое: " + sredArifm);
                clientSocket.close();
            } catch (IOException e) {
                System.err.println(e);
            }
    }
}
