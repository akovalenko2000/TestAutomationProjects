package pages;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class ChangeCurrencyPage extends BasePage{
    public ChangeCurrencyPage(WebDriver driver){super(driver);}

    @FindBy(xpath = "//span[@id = 'a-autoid-0-announce']")
    private WebElement currencySettings;
    @FindBy(xpath = "//a[@id = 'icp-sc-dropdown_23']")
    private WebElement changeCurrencyToEuro;

    public void clickCurrencySetting(){currencySettings.click();}
    public void clickChangeCurrencyToEuro(){changeCurrencyToEuro.click();}


}
