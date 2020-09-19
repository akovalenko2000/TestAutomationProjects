package pages;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class CartPage extends BasePage{
    public CartPage(WebDriver driver){super(driver);}

    @FindBy(xpath = "//div[@class='a-row sc-action-links']//input[contains(@aria-label,'Delete Kindle E-reader (Previous Generation - 8th) - White')]")
    private WebElement deleteWhiteReaderFromCart;
    @FindBy(xpath = "//div[@class='a-row sc-action-links']//input[contains(@aria-label,'Save for later Apple iPad (10.2-inch, Wi-Fi, 32GB) - Space Gray (Latest Model)')]")
    private WebElement saveForLaterIpad;



    public void clickDeleteWhiteReaderFromCart(){deleteWhiteReaderFromCart.click();}
    public void clickSaveForLaterIpad(){saveForLaterIpad.click();}




}
