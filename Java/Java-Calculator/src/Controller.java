import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.scene.input.KeyEvent;
import javafx.event.ActionEvent;
import javafx.scene.layout.GridPane;

public class Controller {
    public Button one;
    public Button two;
    public Button three;
    public Button four;
    public Button five;
    public Button six;
    public Button seven;
    public Button eight;
    public Button nine;
    public Button zero;
    public Button clear;
    public Button div;
    public Button equals;
    public Button minus;
    public Button add;
    public Button mul;
    @FXML
    public TextField res;
    public Button pow;
    public Button sqrt;
    public Button dot;

    boolean dotNum = false;
    boolean num = false;
    boolean operator = false;
    boolean continueCalc = false;
    Calculator calculator = new Calculator();

    @FXML
    public void keyTap(KeyEvent keyEvent) {
        switch (keyEvent.getCharacter()) {
            case "1":
                one.fire();
                break;
            case "2":
                two.fire();
                break;
            case "3":
                three.fire();
                break;
            case "4":
                four.fire();
                break;
            case "5":
                five.fire();
                break;
            case "6":
                six.fire();
                break;
            case "7":
                seven.fire();
                break;
            case "8":
                eight.fire();
                break;
            case "9":
                nine.fire();
                break;
            case "0":
                zero.fire();
                break;
            case "*":
                mul.fire();
                break;
            case "/":
                div.fire();
                break;
            case "+":
                add.fire();
                break;
            case "-":
                minus.fire();
                break;
            case ".":
                dot.fire();
                break;
            case "=":
                equals.fire();
                break;
            case "\b":
                clear.fire();
                break;
        }
    }

    @FXML
    public void numClick(ActionEvent e) {
        zeroDelete();
        String numButtonText = ((Button) e.getSource()).getText();
        if (operator) {
            res.setText(numButtonText);
            operator = false;
        } else {
            res.setText(res.getText() + numButtonText);
        }
        num = true;
    }

    public void zeroDelete() {
        if (res.getText().equals("0")) {
            res.setText("");
        }
    }

    public void buttonDotClick() {
        if (!dotNum) {
            if (num) {
                res.setText(res.getText() + ".");

            } else {
                res.setText("0.");
                operator = false;
            }
            dotNum = true;
        }
    }

    @FXML
    public void CalcOperand2Click(ActionEvent e) {
        if (!DivisionByZero() || !PowAsSqrt()) {
        } else {
            if (num && continueCalc) {
                calculator.setSecondOperand(Double.parseDouble(res.getText()));
                res.setText(Double.toString(calculator.calcValue()));
            } else {
                continueCalc = true;
                if (res.getText().isEmpty()) {
                    calculator.setFirstOperand(0);
                    res.setText("0");
                }
            }
        }
        String operatorButtonText = ((Button) e.getSource()).getText();
        calculator.setOperator(operatorButtonText);
        calculator.setFirstOperand(Double.parseDouble(res.getText()));
        num = false;
        dotNum = false;
        operator = true;
    }

//    @FXML
//    public void buttonPowClick(ActionEvent e) {
//        if (!DivisionByZero()) {
//        } else {
//            if (num && continueCalc) {
//                calculator.setSecondOperand(Double.parseDouble(res.getText()));
//                res.setText(Double.toString(calculator.calcValue()));
//            } else {
//                continueCalc = true;
//                if (res.getText().isEmpty()) {
//                    calculator.setFirstOperand(0);
//                    res.setText("0");
//                }
//            }
//        }
//        //String operatorButtonText = ((Button) e.getSource()).getText();
//        calculator.setOperator("^");
//        calculator.setFirstOperand(Double.parseDouble(res.getText()));
//        num = false;
//        dotNum = false;
//        operator = true;
//    }

    public boolean DivisionByZero() {
        if (Double.parseDouble(res.getText()) == 0.0 && calculator.getOperator().equals("/")) {
            Alert alert = new Alert(Alert.AlertType.ERROR, "Ошибка! Попытка деления на 0");
            alert.show();
            buttonClearClick();
            return false;
        }
        return true;
    }

    public boolean PowAsSqrt() {
        if (Double.parseDouble(res.getText()) == 0.5 && calculator.getFirstOperand() < 0) {
            Alert alert = new Alert(Alert.AlertType.ERROR, "Ошибка! Взятие корня из отрицательного числа");
            alert.show();
            buttonClearClick();
            return false;
        }
        return true;
    }


    @FXML
    public void buttonSqrtClick() {
        if (!DivisionByZero() || !PowAsSqrt()) {
        } else {
            if (Double.parseDouble(res.getText()) < 0) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Ошибка! Взятие корня из отрицательного числа");
                alert.show();
                res.setText("0");
                continueCalc = false;
                calculator.clear();
            } else {
                calculator.setSecondOperand(Double.parseDouble(res.getText()));
                calculator.setOperator("sqrt");
                res.setText(Double.toString(calculator.calcValue()));
            }
            num = false;
            dotNum = false;
        }
    }

    @FXML
    public void buttonEqualsClick() {
        if (!DivisionByZero() || !PowAsSqrt()) {
        } else  if (num && continueCalc) {
            calculator.setSecondOperand(Double.parseDouble(res.getText()));
            if (calculator.getSecondOperand() == 0 && calculator.getOperator().equals("/")) {
                Alert alert = new Alert(Alert.AlertType.ERROR, "Ошибка! Деление на 0");
                alert.show();
                buttonClearClick();
            } else {
                res.setText(Double.toString(calculator.calcValue()));
                calculator.setFirstOperand(Double.parseDouble(res.getText()));
                num = false;
                operator = true;
                continueCalc = false;
                dotNum = false;
            }
//        } else if (!num && calculator.isCheck()) {
//            res.setText(Double.toString(calculator.calcValue()));
//            calculator.setFirstOperand(Double.parseDouble(res.getText()));
        }
        //operator = false;
    }

    @FXML
    public void buttonClearClick() {
        res.setText("0");
        dotNum = false;
        continueCalc = false;
        calculator.clear();
        num = false;
    }
}
