import Exception.*;

import java.util.Collection;


public interface Vehicle {
    String getBrand();
    void setBrand(String brand);
    int getSize();
    void setNameModel(String name, String newName)throws DuplicateModelNameException, NoSuchModelNameException;
    String[] getArrayModels();
    double getPriceModel(String name) throws NoSuchModelNameException;
    void setModelPrice(String name, double newPrice) throws NoSuchModelNameException;
    double[] getPrices();
    void addModel(String name, double price) throws DuplicateModelNameException;
    void deleteModel(String name)throws NoSuchModelNameException;
}
