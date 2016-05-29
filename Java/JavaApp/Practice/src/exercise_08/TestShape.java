package exercise_08;

public class TestShape {

	public static void main(String[] args) {
		Circle s1 = new Circle(2.5);
		s1.setColor("Red");
		s1.printShapeInfo("s1");
		
		Shape s2 = new Rentangle(3,5);
		s2.setColor("Blue");
		s2.printShapeInfo("s2");

	}

}
