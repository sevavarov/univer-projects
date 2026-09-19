
public class PricesThread extends Thread{
    private final Vehicle vehicle;

    public PricesThread(Vehicle vehicle) {
        this.vehicle = vehicle;
    }

    public void run(){
        double[] prices = vehicle.getPrices();
        for(int i = 0; i < vehicle.getSize(); i++){
            System.out.println("Модель " + i + ": " + prices[i]);
        }
    }
}
