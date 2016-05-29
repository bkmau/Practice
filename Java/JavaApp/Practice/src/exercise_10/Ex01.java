package exercise_10;

import org.eclipse.swt.SWT;
import org.eclipse.swt.layout.FillLayout;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Display;

import org.eclipse.swt.widgets.Shell;

public class Ex01 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Display display = new Display();
		Shell shell = new Shell(display);
		
		shell.setLayout(new FillLayout());
		
		
		final Button button = new Button(shell, SWT.PUSH);
	    //button.setBounds(40, 50, 50, 20);
	    button.setText("Click Me");
	    
	    
		
	    shell.pack();
	    shell.open();
		
	    while(!shell.isDisposed())
		{
			if(!display.readAndDispatch())
			{
				display.sleep();
			}
		}
		display.dispose();
		

	}

}
