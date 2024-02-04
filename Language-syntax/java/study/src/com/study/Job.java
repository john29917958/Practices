package com.study;

public class Job implements Runnable {
    private int loopTimes;

    public Job(int loopTimes) {
        this.loopTimes = 5;
    }

    @Override
    public void run() {
        try {
            while (loopTimes > 0) {
                System.out.println(String.format("Loop times: %d", loopTimes));
                Thread.sleep(1000);
                loopTimes -= 1;
            }
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
