package Exception;

public class ModelPriceOutOfBoundsException extends RuntimeException {
    public ModelPriceOutOfBoundsException(){
        super("Неверная цена");
    }
}
