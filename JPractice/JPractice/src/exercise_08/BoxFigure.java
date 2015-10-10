package exercise_08;

public class BoxFigure extends RectangleFigure {
	private double height;

    public BoxFigure() {
	      super();
    }

    public BoxFigure(double l, double w, double h) {
 	      super(l, w);
	      this.height = doesSetZero(h);
    }

    public void setDimension(double l, double w, double h) {
        super.setDimension(l, w);
        this.height = doesSetZero(h);
    }

    public double getHeight() {
        return height;
    }

    public double Area() {
        return  2 * (super.Area(getLength(), getWidth()) + 
        		          super.Area(getLength(), height) +
        		          super.Area(getWidth(), height));
    }

    public double Volume() {
        return super.Area() * height;
    }

    public String toString() {
        return String.format("Length = %.2f; Width = %.2f; Height = %.2f; Surface Area = %.2f; " +
        		                      "Volume = %.2f", getLength(), getWidth(), height, Area(), Volume());
    }
}
