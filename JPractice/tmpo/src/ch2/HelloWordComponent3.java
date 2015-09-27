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

public class HelloWordComponent3 extends JComponent implements 
		MouseMotionListener, ActionListener {

	private static final long serialVersionUID = 1L;
	private String theMessage;
	private int msgX = 125, msgY = 100;
	private JButton btn;
	
	private int colorId;
	private static Color[] someColors ={ Color.black, Color.red, Color.green, Color.blue, Color.magenta };
	
	public HelloWordComponent3(String theMessage) {
		this.theMessage = theMessage;
		btn = new JButton("Change Color");
		setLayout(new FlowLayout());
		add(btn);
		btn.addActionListener(this);
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
	public void mouseMoved(MouseEvent arg0) {}

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

}
