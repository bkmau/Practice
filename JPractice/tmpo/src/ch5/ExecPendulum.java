package ch5;

public class ExecPendulum {

	public static void main(String[] args) {
		Pendulum p1 = new Pendulum();
		
		System.out.println(p1.flag);
		
		Pendulum p2 = new Pendulum();
		p2.flag = 10;
		
		System.out.println(p1.flag);
	}
}
