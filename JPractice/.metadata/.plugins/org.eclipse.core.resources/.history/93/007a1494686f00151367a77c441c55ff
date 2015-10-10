package ch2;

import java.awt.*;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;

import javax.swing.JComponent;

public class HelloWordComponent2 extends JComponent implements MouseMotionListener {
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String theMessage;
	private int msgX = 125, msgY = 100;
	
	public HelloWordComponent2(String theMessage) {
		this.theMessage = theMessage;
		addMouseMotionListener(this);
	}
	
	@Override
	protected void paintComponent(Graphics g) {
		g.drawString(theMessage, msgX, msgY);
	}
	
	@Override
	public void mouseDragged(MouseEvent e) {
		msgX = e.getX();
		msgY = e.getY();
		this.repaint();	
	}

	@Override
	public void mouseMoved(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}
}
