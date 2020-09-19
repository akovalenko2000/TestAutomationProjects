package pages;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class ElectronicsPage extends BasePage{
    public ElectronicsPage(WebDriver driver){super(driver);}
    @FindBy(xpath = "//h2[contains(text(),'Apple iPad (10.2-inch, Wi-Fi, 32GB) - Space Gray (Latest Model)')]")
    private WebElement Ipad;

    public void ClickOnIpad(){Ipad.click();}
}
