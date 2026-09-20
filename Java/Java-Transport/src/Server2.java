import java.net.ServerSocket;
import java.net.Socket;

public class Server2 {
    private static Socket clientSocket;
    private static ServerSocket server;
    public static void main(String[] args){
        try{
            server = new ServerSocket(1);
            while (true){
                clientSocket = server.accept();
                Thread thread = new Thread(new ServerThread(clientSocket));
                thread.start();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
