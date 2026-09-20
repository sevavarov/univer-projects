import java.util.Arrays;
import java.io.Serializable;

import Exception.*;

public class Car implements Vehicle, Serializable, Cloneable{
    private String brand; // Марка автомобиля
    private Model[] models; // Массив моделей автомобиля

    // Конструктор класса
    public Car(String brand, int size) {
        this.brand = brand;
        this.models = new Model[size];
        for (int i = 0; i < size; i++) {
            this.models[i] = new Model(brand + "" + i, (int) (Math.random() * 1000));
        }
    }

    // Метод для получения марки автомобиля
    public String getBrand() {
        return brand;
    }

    // Метод для модификации марки автомобиля
    public void setBrand(String brand) {
        this.brand = brand;
    }

    // Метод для модификации значения названия модели
    public void setNameModel(String name, String newName) throws DuplicateModelNameException, NoSuchModelNameException {
        int num = 0;
        boolean helper = false;
        for (int i = 0; i < models.length; i++) {
            if (newName.equals(models[i].getName()))
                throw new DuplicateModelNameException(newName);
            else if (name.equals(models[i].getName())) {
                num = i;
                helper = true;
            }
        }
        if (!helper)
            throw new NoSuchModelNameException(name);
        else
            models[num].setName(newName);
    }

    // Метод, возвращающий массив названий всех моделей
    public String[] getArrayModels() {
        String[] names = new String[models.length];
        for (int i = 0; i < models.length; i++) {
            names[i] = models[i].getName();
        }
        return names;
    }

    // Метод для получения значения цены модели по её названию
    public double getPriceModel(String name) throws NoSuchModelNameException {
        boolean helper = false;
        double help = 0;
        for(int i = 0; i<models.length; i++){
            if(models[i].getName().equals(name)) {
                helper = true;
                help = models[i].getPrice();
            }
        }
        if (!helper)
            throw new NoSuchModelNameException(name);
        else
            return help;
    }

    // Метод для модификации значения цены модели по её названию
    public void setModelPrice(String name, double price) throws NoSuchModelNameException {
        boolean helper = false;
        int num = 0;
        if (price<0)
            throw new ModelPriceOutOfBoundsException();
        else {
            for (int i = 0; i < models.length; i++) {
                if (models[i].getName().equals(name)) {
                    helper = true;
                    num = i;
                }
            }
            if(!helper)
                throw new NoSuchModelNameException(name);
            else
                models[num].setPrice(price);
        }
    }

    public double[] getPrices()//метод, возвращающий массив значений цен моделей
    {
        double[] prices = new double[models.length];
        for (int i = 0; i < models.length; i++)
            prices[i] = models[i].getPrice();
        return prices;
    }

    // Метод добавления названия модели и её цены
    public void addModel(String name, double price) throws DuplicateModelNameException {
        if(price<0)
            throw new ModelPriceOutOfBoundsException();
        else {
            for (int i = 0; i < models.length; i++) {
                if (name.equals(models[i].getName()))
                    throw new DuplicateModelNameException(name);
            }
            models = Arrays.copyOf(models, models.length + 1);
            models[models.length - 1] = new Model(name, price);
        }
    }

    // Метод удаления модели по заданному имени
    public void deleteModel(String name) throws NoSuchModelNameException {
        boolean helper = false;
        for (int i = 0; i < models.length; i++) {
            if (name.equals(models[i].getName())) {
                System.arraycopy(models, i + 1, models, i, models.length - 1 - i);
                models = Arrays.copyOf(models, models.length - 1);
                helper = true;
                break;
            }
        }
        if(!helper)
            throw new NoSuchModelNameException(name);
    }

    // Метод для получения размера массива Моделей
    public int getSize() {
        return models.length;
    }

    public String toString(){
        StringBuffer sb = new StringBuffer("Марка: " + getBrand() + "\n");
        String[] models = getArrayModels();
        double[] prices = getPrices();
        for (int i = 0; i< getSize();i++){
            sb.append("Модель: " + models[i]).append(", Её цена: " + prices[i] + "\n");
        }
        return sb.toString();
    }

    public boolean equals(Object obj){
        if (this == obj) return true;
        if (obj == null) return false;
        if(!(obj instanceof Vehicle vehicle))
            return false;
        if(!(vehicle.getBrand().equals(this.getBrand())))
            return false;
        String[] modelsO = vehicle.getArrayModels();
        double[] pricesO = vehicle.getPrices();
        if(this.getSize() != vehicle.getSize())
            return false;
        for (int i = 0; i < getSize(); i++){
            if(!(modelsO[i].equals(models[i].getName())))
                return false;
            if (pricesO[i] != models[i].price)
                return false;
        }

        return true;
    }
    public int hashCode() {
        int result = getClass().hashCode();
        result += getBrand() == null ? 0 : getBrand().hashCode();
        if (models != null) {
            for (int i = 0; i < getSize(); i++) {
                result = 31 * result + models[i].getName().hashCode();
                result = 31 * result + (int) models[i].getPrice();
            }
        }
        return result;
    }
    public Object clone() throws CloneNotSupportedException {
        Car clone = (Car) super.clone();
        clone.models = new Model[getSize()];
        for (int i = 0; i < getSize(); i++){
            clone.models[i] = new Model(models[i].getName(), models[i].getPrice());
        }
        return clone;

    }

    // Внутренний класс Модель
    private class Model implements Serializable {
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
