using NullObjectDesignPattern;

var mobileRepository = new MobileRepository();
IMobile sony = mobileRepository.GetMobileByName("sony");
IMobile samsung = mobileRepository.GetMobileByName("samsung");

sony.TurnOn();
sony.TurnOff();

samsung.TurnOn();
samsung.TurnOff();