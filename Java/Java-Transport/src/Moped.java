import Exception.*;
import java.util.LinkedList;

public class Moped implements Vehicle {
    private String brand;
    private LinkedList<Model> models;

    public Moped(String brand, int size)
    {
        this.brand = brand;
        this.models = new LinkedList<>();
        for (int i = 0; i < size; i++){
            models.add(new Model(brand + "" + i, (int) (Math.random() * 1000)));
        }
    }

    @Override
    public String getBrand() {
        return brand;
    }

    @Override
    public void setBrand(String brand) {
        this.brand = brand;
    }

    public int getSize() {
        return models.size();
    }

    @Override
    public void setNameModel(String name, String newName) throws DuplicateModelNameException, NoSuchModelNameException {
        if(!name.equals(newName))
        {
            boolean flagFind = true;
            for (int i = 0; i < models.size(); i++)
            {
                if (models.get(i).getName().equals(newName))
                {
                    throw new DuplicateModelNameException(newName);
                }
                else if (models.get(i).getName().equals(name))
                {
                    models.get(i).setName(newName);
                    flagFind = false;
                }
            }
            if (flagFind)
            {
                throw new NoSuchModelNameException(name);
            }
        }
    }

    @Override
    public String[] getArrayModels() {
        String[] allModels = new String[models.size()];
        for (int i = 0; i < models.size(); i++)
        {
            allModels[i] = models.get(i).getName();
        }
        return allModels;
    }

    @Override
    public double getPriceModel(String name) throws NoSuchModelNameException {
        for (int i = 0; i < models.size(); i++)
        {
            if (models.get(i).getName().equals(name))
            {
                return models.get(i).getPrice();
            }
        }
        throw new NoSuchModelNameException(name);
    }

    @Override
    public void setModelPrice(String name, double newPrice) throws NoSuchModelNameException {
        if(newPrice < 0)
        {
            throw new ModelPriceOutOfBoundsException();
        }
        else
        {
            boolean flagFind = true;
            for (int i = 0; i < models.size(); i++)
            {
                if (models.get(i).getName().equals(name))
                {
                    models.get(i).setPrice(newPrice);
                    flagFind = false;
                }
            }
            if (flagFind)
            {
                throw new NoSuchModelNameException(name);
            }
        }
    }

    @Override
    public double[] getPrices() {
        double[] allPrices = new double[models.size()];
        for (int i = 0; i < models.size(); i++)
        {
            allPrices[i] = models.get(i).getPrice();
        }
        return allPrices;
    }

    @Override
    public void addModel(String name, double price) throws DuplicateModelNameException {
        if(price < 0)
        {
            throw new ModelPriceOutOfBoundsException();
        }
        else
        {
            for (int i = 0; i < models.size(); i++)
            {
                if(models.get(i).getName().equals(name)) {
                    throw new DuplicateModelNameException(name);
                }
            }
            models.add(new Model(name, price));
        }
    }

    @Override
    public void deleteModel(String name) throws NoSuchModelNameException {
        boolean flagFind = true;
        for (int i = 0; i < models.size(); i++)
        {
            if(models.get(i).getName().equals(name))
            {
                models.remove(i);
                flagFind = false;//Элемент для удаления найден
            }
        }
        if (flagFind)
        {
            throw new NoSuchModelNameException(name);
        }
    }
    public String toString() {
        StringBuffer sb = new StringBuffer("Марка: " + getBrand() + "\n");
        String[] models = getArrayModels();
        double[] prices = getPrices();
        for (int i = 0; i < getSize(); i++)
            sb.append("Модель: " + models[i]).append(", Её цена: " + prices[i] + "\n");
        return sb.toString();
    }
    private class Model {
        private String name; // Название модели
        private double price; // Цена модели

        // Конструктор класса Модель
        public Model(String name, double price) {
            this.name = name;
            this.price = price;
        }

        // Метод для модификации значения названия модели
        public void setName(String name) {
            this.name = name;
        }

        // Метод для получения значения названия модели
        public String getName() {
            return name;
        }

        // Метод для получения значения цены модели
        public double getPrice() {
            return price;
        }

        // Метод для модификации значения цены модели
        public void setPrice(double price) {
            this.price = price;
        }

    }
}
