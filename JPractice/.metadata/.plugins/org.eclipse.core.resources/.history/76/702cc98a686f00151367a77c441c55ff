package ch2;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;

import javax.swing.JButton;
import javax.swing.JComponent;

public class HelloWordComponent4 extends JComponent implements
		MouseMotionListener, ActionListener, Runnable {

	private static final long serialVersionUID = 1L;
	private String theMessage;
	private int msgX = 125, msgY = 100;
	private JButton btn;
	
	private int colorId;
	private static Color[] someColors ={ Color.black, Color.red, Color.green, Color.blue, Color.magenta };
	
	private boolean blinkState;
	
	public HelloWordComponent4(String theMessage) {
		this.theMessage = theMessage;
		btn = new JButton("Change Color");
		setLayout(new FlowLayout());
		add(btn);
		btn.addActionListener(this);
		addMouseMotionListener(this);
		
		Thread t = new Thread(this);
		t.start();
	}
	
	@Override
	protected void paintComponent(Graphics g) {
		g.setColor(blinkState ? getBackground() : currentColor());
		g.drawString(theMessage, msgX, msgY);
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		if(e.getSource() == btn) {
			changeColor();
		}
	}
	
	synchronized private void changeColor() {
		if (++colorId == someColors.length) {
		      colorId = 0;
		}
		setForeground(currentColor());
		repaint();
	}
	
	synchronized private Color currentColor() {
		return someColors[colorId];
	}

	@Override
	public void mouseDragged(MouseEvent e) {
		msgX = e.getX();
		msgY = e.getY();
		this.repaint();
	}

	@Override
	public void mouseMoved(MouseEvent e) {}

	@Override
	public void run() {
		try {
	      while(true) {
	        blinkState = !blinkState;
	        repaint(); 
	        Thread.sleep(300);
	      }
	    } catch (InterruptedException ie) { }
	}

}
