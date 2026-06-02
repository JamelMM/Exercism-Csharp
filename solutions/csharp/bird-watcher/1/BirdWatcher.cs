class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
      int[] lastWeek = new int[] {0, 2, 5, 3, 7, 8, 4};
      return lastWeek;
    }

    public int Today()
    {
        
        int birdCount = birdsPerDay[birdsPerDay.Length - 1];
        return birdCount;
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] += 1;
        
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int day in birdsPerDay)
        {
            if (day == 0)
            {
                return true;
            } 
            
        }
       return false; 
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        
        for(int i = 0; i < numberOfDays; i++)
        {
             sum += birdsPerDay[i];
            
        }
        return sum;
    }

    public int BusyDays()
    {
        int count = 0;
        
        foreach(int days in birdsPerDay){

            if (days >= 5){
                
                count++;
            }
        }
        return count;
    }
}
