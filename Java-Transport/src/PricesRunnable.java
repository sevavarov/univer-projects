public class PricesRunnable implements Runnable{
    private final TransportSynchronizer transportSynchronizer;

    public PricesRunnable(TransportSynchronizer transportSynchronizer) {
        this.transportSynchronizer = transportSynchronizer;
    }
    @Override
    public void run() {
        while (transportSynchronizer.canPrintPrice()){
            try {
                transportSynchronizer.printPrice();
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }
}
