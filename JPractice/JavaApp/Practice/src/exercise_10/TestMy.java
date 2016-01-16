package exercise_10;

import org.eclipse.swt.SWT;
import org.eclipse.swt.layout.FillLayout;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Shell;

public class TestMy {

	public static void main(String[] args) {
		Display display = new Display();
		Shell shell = new Shell(display);
		
		shell.setLayout(new FillLayout());
		
		
		My my = new My(shell, SWT.None);
		
		My my1 = new My(shell, SWT.None);
	    
	    
		
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
