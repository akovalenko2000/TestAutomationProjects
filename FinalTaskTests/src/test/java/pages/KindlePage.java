package pages;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class KindlePage extends BasePage{
    public KindlePage(WebDriver driver){super(driver);}
    //click white
    //click add to cart
    @FindBy(xpath = "//li[@class ='swatchSelect']//img[@class='imgSwatch']")
    private WebElement whiteColourBook;
    @FindBy(xpath = "//input[@id ='add-to-cart-button-ubb']")
    private WebElement addToCartButton;




    public void clickOnWhitColourBook(){whiteColourBook.click();}
    public void clickAddToCart(){addToCartButton.click();}

}
