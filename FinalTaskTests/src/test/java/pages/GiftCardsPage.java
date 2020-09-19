package pages;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

import java.nio.file.Watchable;

public class GiftCardsPage extends BasePage{
    public GiftCardsPage(WebDriver driver){super(driver);}

    @FindBy(xpath = "//img[@alt='Birthday Gift Cards']")
    private WebElement birthdayCard;
    //
    @FindBy(xpath = "//img[contains(@alt,'Birthday cake')]")
    private WebElement birthdayCakeCard;
    //
    @FindBy(xpath = "//button[@value='25']")
    private WebElement card25Usd;


    public void clickBirthdayCard(){birthdayCard.click();}
    public void clickBirthdayCakeCard(){birthdayCakeCard.click();}
    public void clickCard25Usd(){card25Usd.click();}


}
