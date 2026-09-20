import Exception.*;

import java.io.*;
import java.lang.reflect.*;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.locks.ReentrantLock;

public class Main {
    public static void main(String[] args) throws DuplicateModelNameException, ModelPriceOutOfBoundsException, IOException, ClassNotFoundException, CloneNotSupportedException, NoSuchMethodException, InvocationTargetException, IllegalAccessException, NoSuchFieldException, InstantiationException, NoSuchModelNameException, InterruptedException {
        //1 задание
        Car car = new Car("Audi", 5);
       /* PricesThread one = new PricesThread(car);
        ModelsThread second = new ModelsThread(car);
        one.setPriority(Thread.NORM_PRIORITY);
        second.setPriority(Thread.NORM_PRIORITY);
        one.start();
        second.start();*/
        //1 задание: Создать два класса нитей (наследуют от класса Thread),
        // взаимодействующих с помощью промежуточного объекта типа интерфейс Транспортного средства.
        //Первая нить последовательно выводит на экран цены на модели транспортного средства.
        //Вторая нить последовательно выводит на экран названия моделей транспортного средства.
        //В методе main() следует создать 3 участвующих в процессе объекта
        // (транспортное средство и две нити) и запустить нити на выполнение.
        // Запустите программу несколько раз. Попробуйте варьировать приоритеты нитей.


        //2 задание:
        /*TransportSynchronizer transportSynchronizer = new TransportSynchronizer(car);
        Thread pricesRunnable = new Thread(new PricesRunnable(transportSynchronizer));
        Thread modelsRunnable = new Thread(new ModelsRunnable(transportSynchronizer));
        modelsRunnable.start();
        pricesRunnable.start();*/

        //Создайте два новых класса нитей (реализуют интерфейс Runnable),
        // обеспечивающих последовательность операций вывода моделей и цен на модели
        // (т.е. на экран выводятся модель-цена-модель-цена…) независимо от приоритетов потоков.
        // Для этого потребуется описать некий вспомогательный класс TransportSynchronizer,
        // объект которого будет использоваться при взаимодействии нитей.

        //3 задание
        /*ReentrantLock lock = new ReentrantLock();
        Thread pricesLock = new Thread(new PricesLock(car, lock));
        Thread modelsLock = new Thread(new ModelsLock(car, lock));
        modelsLock.start();
        pricesLock.start();*/

        //4 задание
        /*Car car1 = new Car("Audi", 6);
        Bike bike1 = new Bike("Yamaha", 4);
        Moped moped = new Moped("Alpha", 3);
        QuadBike quadBike = new QuadBike("Suzuki", 5);
        Vehicle[] vehicle = new Vehicle[]{car1, bike1, moped, quadBike};
        ExecutorService executor = Executors.newFixedThreadPool(2);
        for (Vehicle v : vehicle)
            executor.execute(new BrandRunnable(v));
        executor.shutdown();*/

        //5 задание
       /* ArrayBlockingQueue<String> queue = new ArrayBlockingQueue<>(2);
        String[] files = new String[]{"f1.txt", "f2.txt", "f3.txt", "f4.txt", "f5.txt"};
        for (String s: files){
            Thread thread = new Thread(new BrandQueue("src/" + s, queue));
            thread.start();
        }
        for(int i = 0; i < files.length; i++){
            System.out.println(queue.take());
        }*/

        /*Написать код (можно в методе main()), который с помощью рефлексии вызывает метод
        для модификации значения цены модели по её названию класса Автомобиль.
        В параметрах командной строки приложения указывается полное имя класса, имя метода,
                который следует вызвать у класса (метод нестатический) и параметры для этого метода.
                На экран должен быть выведен результат выполнения этого метода
        (информация об автомобиле, включая марку автомобиля, названия всех моделей и их цены).*/
        /*Class<?> clazz = Class.forName(args[0]);
        Class[] params = {String.class, int.class};
        Object carRef = clazz.getConstructor(params).newInstance("Ford", 3);
        Method method = clazz.getMethod(args[1], String.class, double.class);
        method.invoke(carRef, args[2], Double.parseDouble(args[3]));
        System.out.println(carRef);
///////////////////////////////////////////////////////////////////////////////

        Car car1 = new Car("Honda", 4);
        Vehicle vehicle = Task5.reflectVehicle("Porshe", 2, car1);
        System.out.println(vehicle);
//////////////////////////////////////////////////////////////////////////////////
        Scooter scooter = new Scooter("Scooter", 5);
        scooter.addModel("Model4", 300);
        scooter.addModel("Model5", 400);
        scooter.addModel("Model6", 1000);

        System.out.println(scooter);
        System.out.println();
        scooter.setNameModel("Scooter2", "New");
        System.out.println(scooter);

        System.out.println();
        System.out.println(Arrays.toString(scooter.getArrayModels()));
        System.out.println(Arrays.toString(scooter.getPrices()));
        System.out.println();

        System.out.println("Цена модели Model4: "  + scooter.getPriceModel("Model4"));
        System.out.println();

        scooter.setModelPrice("Model4", 88888);
        System.out.println(scooter);
        System.out.println();

        //Задание 4
        quadBike quadBike = new quadBike("QuadBike", 4);
        quadBike.addModel("Model5", 300);
        quadBike.addModel("Model6", 150);

        System.out.println(quadBike);

        System.out.println();
        System.out.println("Цена модели Model5: " + quadBike.getPriceModel("Model5"));
        System.out.println();
        quadBike.setModelPrice("Model5", 55555);
        quadBike.setNameModel("Model5", "New");
        quadBike.deleteModel("QuadBike1");
        System.out.println(Arrays.toString(quadBike.getArrayModels()));
        System.out.println(Arrays.toString(quadBike.getPrices()));
        System.out.println();
        ///////////////////////////////////////////////////////

        Moped moped = new Moped("Moped", 3);
        moped.addModel("Model4", 111);
        moped.addModel("Model5", 222);
        moped.addModel("Model6", 333);

        System.out.println(moped);

        System.out.println();
        System.out.println();
        moped.setNameModel("Model4", "New");
        System.out.println("Цена модели Model5: " + moped.getPriceModel("Model5"));
        System.out.println();
        moped.setModelPrice("Model5", 1111111);
        System.out.println(Arrays.toString(moped.getArrayModels()));
        System.out.println(Arrays.toString(moped.getPrices()));
        System.out.println();
        ////////////////////////////////////////////////////////

        System.out.println("Средняя арифметическая цена моделей скутера, квадроцикла и мопеда: " + Task5.sredValueVehicles(scooter, quadBike, moped));
        //////////////////////////////////////////////////////////////

        System.out.println("Введите марку автомобиля, количество моделей, название модели и ее цену.");
        Vehicle car = Task5.readVehicle();
        Task5.writeVehicle(car);*/





        /*String filename = "vehicleByte.txt";
        FileOutputStream fileOutput = new FileOutputStream(filename);
        Task5.outputVehicle(car, fileOutput);
        FileInputStream fileInput = new FileInputStream(filename);
        Vehicle vehicle = Task5.inputVehicle(fileInput);
        System.out.println(vehicle.getBrand());
        System.out.println(vehicle.getSize());
        Task5.outNames(vehicle);
        Task5.outPrices(vehicle);
        System.out.println();

        filename = "vehicleSymbol.txt";
        FileWriter fWrite = new FileWriter(filename);
        Task5.writeVehicle(moto, fWrite);
        FileReader fRead = new FileReader(filename);
        Vehicle vehicle2 = Task5.readVehicle(fRead);
        System.out.println(vehicle2.getBrand());
        System.out.println(vehicle2.getSize());
        Task5.outNames(vehicle2);
        Task5.outPrices(vehicle2);
        System.out.println();


        System.out.println("Введите тип модели, название марки, количество моделей, имя i-ой модели и цену:");
        vehicle2 = Task5.readVehicle(new InputStreamReader(System.in));
        Task5.writeVehicle(vehicle2, new OutputStreamWriter(System.out));
        System.out.println();

        filename = "vehicleSerializable.txt";
        FileOutputStream fos = new FileOutputStream(filename);
        ObjectOutputStream oos = new ObjectOutputStream(fos);
        oos.writeObject(car);
        FileInputStream fis = new FileInputStream(filename);
        ObjectInputStream ois = new ObjectInputStream(fis);
        Vehicle vehicle3 = (Vehicle) ois.readObject();
        System.out.println(vehicle3.getBrand());
        System.out.println(vehicle3.getSize());
        Task5.outNames(vehicle3);
        Task5.outPrices(vehicle3);
        System.out.println();
        fos.close();
        oos.close();
        fis.close();
        ois.close();*/

        /*System.out.println(car);
        System.out.println(moto.toString());
        System.out.println("Хеш-код автомобиля: " + car.hashCode());
        System.out.println("Хеш-код мотоцикла: " + moto.hashCode());
        Vehicle clone = (Vehicle) car.clone();
        System.out.println("Car:\n" + car.toString());
        System.out.println();
        System.out.println("Clone:\n" + clone.toString());
        Vehicle cloneM = (Vehicle) moto.clone();
        System.out.println("Moto:\n" + moto.toString());
        System.out.println();
        System.out.println("Clone:\n" + cloneM.toString());*/
        /*fileInput.close();
        fileOutput.close();
        fWrite.close();
        fRead.close();*/
    }
}
