package pages;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class IpadPage extends BasePage{
    public IpadPage(WebDriver driver){super(driver);}
    @FindBy(xpath = "//span[text() = 'Add to Cart']")
    private WebElement addToCartButton;

    public void clickAddToCartButton(){addToCartButton.click();}
}
