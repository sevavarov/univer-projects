public class Calculator {
    private double firstOperand;
    private double secondOperand;
    private String operator;
    private double result;
    private boolean check;

    public double getFirstOperand() {
        return firstOperand;
    }

    public void setFirstOperand(double firstOperand) {
        this.firstOperand = firstOperand;
    }

    public double getSecondOperand() {
        return secondOperand;
    }

    public void setSecondOperand(double secondOperand) {
        this.secondOperand = secondOperand;
    }

    public String getOperator() {
        return operator;
    }

    public void setOperator(String operator) {
        this.operator = operator;
    }

    public double getResult() {
        return result;
    }

    public void setResult(double result) {
        this.result = result;
    }

    public boolean isCheck() {
        return check;
    }

    public void setCheck(boolean check) {
        this.check = check;
    }

    public void clear() {
        firstOperand = 0;
        operator = "";
        secondOperand = 0;
        result = 0;
        check = false;
    }

    public double calcValue() {
        switch (operator) {
            case "+":
                result = firstOperand + secondOperand;
                break;
            case "-":
                result = firstOperand - secondOperand;
                break;
            case "*":
                result = firstOperand * secondOperand;
                break;
            case "/":
                result = firstOperand / secondOperand;
                break;
            case "^":
                result = Math.pow(firstOperand, secondOperand);
                break;
            case "sqrt":
                result = Math.sqrt(secondOperand);
                break;
        }
        check = true;
        return result;
    }
}