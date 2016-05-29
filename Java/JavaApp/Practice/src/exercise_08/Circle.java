package exercise_08;

public class Circle extends Shape implements IShape{
	private double radious;
	final double pi = 3.14;
	
	public Circle(double radious) {
		this.radious = radious;
	}
    
	public double getRadious() {
		return radious;
	}
	
	public void setRadious(double radious) {
		this.radious = radious;
	}

	public double getPi() {
		return pi;
	}
	
	@Override
	public double Area() {
		return (radious*radious*pi);
	}

	@Override
	public double Perimeter() {
		return (radious*2*pi);
	}

	@Override
	public void printShapeInfo(String name) {
		super.printShapeInfo(name);
	    System.out.print(" Radious : "+ radious + "\r" + 
		                         "         PI : "+ pi + "\r" +
	    		                 "Perimeter: " + Perimeter() + "\r" +
	    		                 "       Area:" + Area() + "\r");
	}

}
