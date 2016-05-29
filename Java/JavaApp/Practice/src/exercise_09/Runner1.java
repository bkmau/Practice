package exercise_09;

public class Runner1 {
	private String msg;

	public Runner1(String msg) {
		this.msg = msg;
	}
	
	public void run() {
		for(int i=0;i<4;i++) {
			for(int j=0;j<100000000;j++);
			System.out.println(msg + ">");
		} 
	}
}
