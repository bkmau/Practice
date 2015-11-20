package exercise_09;

public class Runner3 implements Runnable {
	private String msg;
	
	public Runner3(String msg) {
		this.msg = msg;
	}

	@Override
	public void run() {
		for(int i=0;i<4;i++) {
			for(int j=0;j<100000000;j++);
			System.out.println(msg + ">");
		}
	}

}
