import java.io.Serializable;
import java.time.Instant;

import Exception.*;

public class Bike implements Vehicle, Serializable, Cloneable {
    private String brand;
    private int size;
    private Model head;
    private transient long lastModified;
    {
        head = new Model();
        head.next = head;
        head.prev = head;
        lastModified = Instant.now().getEpochSecond();
    }
    public long getLastModified() { return lastModified; }
    public String getBrand()
    {
        return brand;
    }
    public void setBrand(String brand)
    {
        this.brand = brand;
        lastModified = Instant.now().getEpochSecond();
    }
    //метод для получения размера массива Моделей.
    public int getSize(){return size;}
    //Конструктор
    Bike(String MarkaB, int size){
        this.brand = MarkaB;
        this.size = size;
        Model q;
        for (int i = 0; i < size; i++){
            q = new Model(brand + " " + i, (int) (Math.random() * 1000));
            q.next = head;
            q.prev = head.prev;
            head.prev.next = q;
            head.prev = q;
        }
    }
    //метод для модификации значения названия модели
    public void setNameModel(String name, String newName) throws DuplicateModelNameException, NoSuchModelNameException{
        boolean helper = false;
        Model help = head.next;
        while (help != head) {
            if (help.getNameModel().equals(newName))
                throw new DuplicateModelNameException(newName);
            help = help.next;
        }
        help = head.next;
        while (help != head) {
            if (help.getNameModel().equals(name)){
                helper = true;
                help.setNameModel(newName);
                lastModified = Instant.now().getEpochSecond();
                break;
            }
            help = help.next;
        }
        if (!helper)
            throw new NoSuchModelNameException(name);

    }
    //метод, возвращающий массив названий всех моделей
    public String[] getArrayModels(){
        String[] models = new String[size];
        Model help = head.next;
            for (int i = 0; i < size; i++) {
                models[i] = help.getNameModel();
                help = help.next;
            }
        return models;
    }
    //метод для получения значения цены модели по её названию
    public double getPriceModel(String name)throws NoSuchModelNameException{
        boolean helper = false;
        double itog = 0;
        Model help = head.next;
        while (help != head){
            if (help.getNameModel().equals(name)) {
                helper = true;
                itog = help.getPrice(); // break ?
            }
            help = help.next;
        }
        if(helper)
            return itog;
        else
            throw new NoSuchModelNameException(name);
    }
//метод для модификации значения цены модели по её названию
    public void setModelPrice(String name, double newPrice) throws NoSuchModelNameException{
        boolean helper = false;
        Model help = head.next;
        if(newPrice < 0)
            throw new ModelPriceOutOfBoundsException();
        else {
            while (help != head) {
                if (help.getNameModel().equals(name)) {
                    help.setPrice(newPrice);
                    helper = true;
                    lastModified = Instant.now().getEpochSecond();
                    break;
                }
                help = help.next;
            }
        }
        if(!helper)
            throw new NoSuchModelNameException(name);
    }
    //метод, возвращающий массив значений цен моделей
    public double[] getPrices(){
        double[] prices = new double[size];
        Model help = head.next;
        for (int i = 0; i < size; i++) {
            prices[i] = help.getPrice();
            help = help.next;
        }
        return prices;
    }
    //добавления названия модели и её цены
    public void addModel(String name, double price) throws DuplicateModelNameException{
        Model help;
        if(price < 0)
            throw new ModelPriceOutOfBoundsException();
        else {
            help = head.next;
            while (help != head) {
                if (help.getNameModel().equals(name))
                    throw new DuplicateModelNameException(name);
                help = help.next;
            }
            help = new Model(name, price);
            help.next = head;
            help.prev = head.prev;
            head.prev.next = help;
            head.prev = help;
            size++;
            lastModified = Instant.now().getEpochSecond();
        }

    }
    //метод удаления модели по заданному имени
    public void deleteModel(String name)throws NoSuchModelNameException {
        Model help = head.next;
        boolean helper = false;
        while (help != head){
            if(help.getNameModel().equals(name)){
                help.prev.next = help.next;
                help.next.prev = help.prev;
                helper = true;
                size--;
                lastModified = Instant.now().getEpochSecond();
                break;
            }
            help = help.next;
        }
        if (!helper)
            throw new NoSuchModelNameException(name);
    }
    public String toString(){
        Model help = head.next;
        StringBuffer sb = new StringBuffer("Марка: " + getBrand() + "\n");
        for (int i = 0; i< getSize();i++){
            sb.append("Модель: " + help.getNameModel()).append(", Её цена: " + help.getPrice() + "\n");
            help = help.next;
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
        String[] modelsV = vehicle.getArrayModels();
        double[] pricesV = vehicle.getPrices();
        String[] modelsT = getArrayModels();
        double[] pricesT = getPrices();
        if(this.getSize() != vehicle.getSize())
            return false;
        for (int i = 0; i < getSize(); i++) {
            if (!(modelsT[i].equals(modelsV[i])))
                return false;
            if ((pricesT[i] != (pricesV[i])))
                return false;
        }
        return true;
    }
    public int hashCode() {
        int result = getClass().hashCode();
        result += getBrand() == null ? 0 : getBrand().hashCode();
        if(head != null){
            Model help = head.next;
            for (int i = 0; i < getSize(); i++) {
                result = 31 * result + help.getNameModel().hashCode();
                result = 31 * result + (int) help.getPrice();
            }
        }
        return result;
    }
    public Object clone() throws CloneNotSupportedException {
        Bike clone = (Bike) super.clone();
        int size = this.getSize();
        clone.head = new Model();
        clone.head.next = clone.head;
        clone.head.prev = clone.head;
        Model help = head.next;
        Model q;
        for (int i = 0; i < size; i++){
            q = new Model(help.getNameModel(), help.getPrice());
            q.next = clone.head;
            q.prev = clone.head.prev;
            clone.head.prev.next = q;
            clone.head.prev = q;
            help = help.next;
        }
        return clone;
    }
    private class Model implements Serializable {
        String nameModel = null;
        double price = Double.NaN;
        Model prev = null;
        Model next = null;
        Model(){}
        Model(String nameModel, double price){
            this.nameModel = nameModel;
            this.price = price;
        }
        public String getNameModel(){
            return nameModel;
        }
        public void setNameModel(String nameModel){
            this.nameModel = nameModel;
        }
        public double getPrice(){return price;}
        public void setPrice(double price){this.price = price;}
    }

}