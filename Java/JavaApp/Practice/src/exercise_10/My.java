package exercise_10;

import org.eclipse.swt.SWT;
import org.eclipse.swt.layout.FillLayout;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;


public class My extends Composite {

	public My(Composite parent, int style) {
		super(parent, style);
		// TODO Auto-generated constructor stub
		
		//Display display = new Display();
		
		
		this.setLayout(new FillLayout());
		
		
		final Button button = new Button(this, SWT.PUSH);
	    //button.setBounds(40, 50, 50, 20);
	    button.setText("Click Me");
	    
	    final Button button2 = new Button(this, SWT.PUSH);
	    button2.setText("xx");
	    
	    
		/*
	    this.pack();
	    this.open();
		
	    while(!this.isDisposed())
		{
			if(!display.readAndDispatch())
			{
				display.sleep();
			}
		}
		display.dispose(); */
	}

}
