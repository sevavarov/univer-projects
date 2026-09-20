import Exception.*;
import java.io.*;
import java.lang.reflect.*;
import java.util.Arrays;
import java.util.Scanner;

public class Task5
{
    public static double average(Vehicle vehicle)
    {
        double sum = 0;
        double[] help;
        help = vehicle.getPrices();
        for (int i = 0; i < help.length; i++)
            sum += help[i];
        return sum / vehicle.getSize();
    }
    public static double sredValueVehicles(Vehicle... vehicles){
        if(vehicles.length != 0){
            double sred = 0;
            double[] prices = null;
            int i = 0;
            for(Vehicle veh : vehicles) {
                prices = veh.getPrices();
                for (double var : prices) {
                    sred += var;
                    i++;
                }
            }
            return sred/i;
        }
        else
            return 0;

    }

    public static void outNames(Vehicle vehicle)
    {
        System.out.println(Arrays.toString(vehicle.getArrayModels()));
    }
    public static void outPrices(Vehicle vehicle)
    {
        System.out.println(Arrays.toString(vehicle.getPrices()));
    }
    //записи информации о транспортном средстве в байтовый поток
    public static void outputVehicle(Vehicle v, OutputStream out) throws IOException {
    DataOutputStream is = new DataOutputStream(out);
    byte[] Class = v.getClass().getName().getBytes();
    is.writeInt(Class.length);
    for(byte var : Class)
        is.writeByte(var);
    byte[] Marka = v.getBrand().getBytes();
    is.writeInt(Marka.length);
    for (byte var : Marka) {
        is.writeByte(var);
    }
    is.writeInt(v.getSize());
    String[] models = v.getArrayModels();
    double[] prices = v.getPrices();
    for (int i = 0; i < v.getSize(); i++) {
        byte[] Model = models[i].getBytes();
        is.writeInt(Model.length);
        for(byte model : Model)
            is.writeByte(model);
        is.writeDouble(prices[i]);
    }
    }

    //чтения информации о транспортном средстве из байтового потока
    public static Vehicle inputVehicle(InputStream in) throws IOException, DuplicateModelNameException {
        DataInputStream is = new DataInputStream(in);
        byte[] Class = new byte[is.readInt()];
        for(int i = 0; i < Class.length; i++)
            Class[i] = is.readByte();
        byte[] Brand = new byte[is.readInt()];
        for(int i = 0; i < Brand.length; i++)
            Brand[i] = is.readByte();
        int Size = is.readInt();
        Vehicle newV = null;
        String newClass = new String(Class);
        String newBrand = new String(Brand);
        if(newClass.equals("Car"))
            newV = new Car(newBrand, 0);
        else if(newClass.equals("Bike"))
            newV = new Bike(newBrand,0);
        if (newV != null){
            for (int i = 0; i < Size; i++) {
                byte[] model = new byte[is.readInt()];
                for(int j = 0; j < model.length; j++)
                    model[j] = is.readByte();
                String nModel = new String(model);
                newV.addModel(nModel, is.readDouble());
            }
        }
        return newV;
    }







    public static void writeVehicle(Vehicle v){
        System.out.printf("Марка автомобиля: %s%n", v.getBrand());
        for (int i = 0; i < v.getSize(); i++)
        {
            System.out.printf("Название модели: %s , ", v.getArrayModels()[i]);
            System.out.printf("Цена модели: %.1f%n", v.getPrices()[i]);
        }
    }

    public static Vehicle readVehicle() throws IOException, DuplicateModelNameException, NoSuchModelNameException {
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        double price;
        String modelName;
        int size = Integer.parseInt(scanner.nextLine());
        Vehicle vehicle = new Car(name, size);
        for (int i = 0; i < size; i++)
        {
            modelName = scanner.nextLine();
            price = Double.parseDouble(scanner.nextLine());
            vehicle.setNameModel(vehicle.getArrayModels()[i], modelName);
            vehicle.setModelPrice(vehicle.getArrayModels()[i], price);
        }
        return vehicle;
    }
    public static Vehicle reflectVehicle(String brand, int size, Vehicle vehicle) throws ClassNotFoundException, NoSuchMethodException, InvocationTargetException, InstantiationException, IllegalAccessException {
        Vehicle newVeh;
        if (brand != null && size != 0) {
            Class clazz = vehicle.getClass();
            Constructor constructor = clazz.getConstructor(String.class, int.class);
            newVeh = (Vehicle) constructor.newInstance(brand, size);
            return newVeh;
        } else
            return null;
    }
}
