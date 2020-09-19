import org.openqa.selenium.WebElement;
import org.testng.annotations.Test;

import static org.testng.Assert.assertTrue;

public class ChangeCurrencyTest extends BaseStepsTest{
    @Test
    public void checkChangeCurrencyTest(){
        String CURRENCY_EURO = "You will be shown prices in € - EUR - Euro on www.amazon.com as a reference only.";
        getHomePage().clickChangeCurrencyButton();
        getChangeCurrencyPage().clickCurrencySetting();
        getChangeCurrencyPage().clickChangeCurrencyToEuro();
        WebElement webElement = null;
        assertTrue(webElement.getText().contains(CURRENCY_EURO));


    }

}
