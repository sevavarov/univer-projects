import java.util.Collection;
import java.util.HashMap;
import Exception.*;

public class Scooter implements Vehicle {
    private String brand;
    private HashMap<String, Double> model;
    public Scooter(String brand, int size){
        this.brand = brand;
        model = new HashMap<>();
        for (int i = 0; i < size; i++){
            model.put(brand + "" + i, (double) (Math.random() * 1000));
        }
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    @Override
    public int getSize() {
        return model.size();
    }

    @Override
    public void setNameModel(String name, String newName) throws DuplicateModelNameException, NoSuchModelNameException {
        if(model.containsKey(newName))
            throw new DuplicateModelNameException(newName);
        else if (model.containsKey(name)){
            model.put(newName, model.get(name));
            model.remove(name);
        }
        else
            throw new NoSuchModelNameException(name);
    }

    @Override
    public String[] getArrayModels() {
        String[] allModels = new String[model.size()];
        int i = 0;
        for (String key : model.keySet())
        {
            allModels[i] = key;
            i++;
        }
        return allModels;
    }

    @Override
    public double getPriceModel(String name) throws NoSuchModelNameException {
        if(model.containsKey(name))
            return model.get(name);
        else
            throw new NoSuchModelNameException(name);
    }

    @Override
    public void setModelPrice(String name, double newPrice) throws NoSuchModelNameException {
        if(model.containsKey(name)){
            if(newPrice >= 0)
                model.put(name, newPrice);
            else
                throw new ModelPriceOutOfBoundsException();
        }
        else
            throw new NoSuchModelNameException(name);
    }

    @Override
    public double[] getPrices() {
        double[] prices = new double[model.size()];
        int i = 0;
        for (double help: model.values()) {
            prices[i] = help;
            i++;
        }
        return prices;
    }

    @Override
    public void addModel(String name, double price) throws DuplicateModelNameException {
        if(!model.containsKey(name)){
            if(price >= 0)
                model.put(name, price);
            else
                throw new ModelPriceOutOfBoundsException();
        }
        else
            throw new DuplicateModelNameException(name);
    }

    @Override
    public void deleteModel(String name) throws NoSuchModelNameException {
        if(model.containsKey(name))
            model.remove(name);
        else
            throw new NoSuchModelNameException(name);
    }
    public String toString() {
        StringBuffer sb = new StringBuffer("Марка: " + getBrand() + "\n");
        String[] models = getArrayModels();
        double[] prices = getPrices();
        for (int i = 0; i < getSize(); i++)
            sb.append("Модель: " + models[i]).append(", Её цена: " + prices[i] + "\n");
        return sb.toString();
    }
}
