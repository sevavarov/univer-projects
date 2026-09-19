public class ModelsThread extends Thread{
    private final Vehicle vehicle;

    public ModelsThread(Vehicle vehicle) {
        this.vehicle = vehicle;
    }

    public void run(){
        String[] models = vehicle.getArrayModels();
        for(int i = 0; i < vehicle.getSize(); i++){
            System.out.println("Модель " + i + ": " + models[i]);
        }
    }
}
