package exercise_09;

public class Runner4 extends Thread {
	private String msg;
	
	public Runner4(String msg) {
		this.msg = msg;
	}

	@Override
	public void run() {
		for(int i=0;i<4;i++) {
			try {
				sleep((int)(1000*Math.random()));
			} catch (InterruptedException e) {
				
			}
		   System.out.println(msg + " is running..");
		}
	}

}
