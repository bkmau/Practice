package exercise_01;

import javax.swing.JFrame;

public class HelloWord3 {
	public static void main(String[] args){
		JFrame frame = new JFrame("Hello, world");
		frame.add(new HelloWordComponent3("Hello, world"));
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize(300,300);
		frame.setVisible(true);
	}	
}
