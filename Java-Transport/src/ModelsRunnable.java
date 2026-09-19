public class ModelsRunnable implements Runnable{
    private final TransportSynchronizer transportSynchronizer;

    public ModelsRunnable(TransportSynchronizer transportSynchronizer) {
        this.transportSynchronizer = transportSynchronizer;
    }
    @Override
    public void run() {
        while (transportSynchronizer.canPrintModel()){
            try {
                transportSynchronizer.printModel();
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }
}
