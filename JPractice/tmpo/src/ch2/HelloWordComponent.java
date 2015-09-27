package ch2;

import java.awt.*;

import javax.swing.JComponent;


public class HelloWordComponent extends  JComponent{
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	
	@Override
	public void paintComponent(Graphics g) {
		g.drawString("Hello, world", 125, 100);
	}

}
