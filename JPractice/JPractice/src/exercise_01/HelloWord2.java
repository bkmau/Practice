package exercise_01;

import javax.swing.*;


public class HelloWord2 {

	public static void main(String[] args) {
		JFrame frame = new JFrame(args[0].toString());
		frame.add(new HelloWordComponent2("Hello, world"));
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize(300,300);
		frame.setVisible(true);
	}
}
