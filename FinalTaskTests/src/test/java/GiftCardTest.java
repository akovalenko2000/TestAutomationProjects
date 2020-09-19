import org.openqa.selenium.WebElement;
import org.testng.annotations.Test;

import static org.testng.Assert.assertTrue;

public class GiftCardTest extends BaseStepsTest{
    @Test
    public void checkChangingPriceGiftCard()
    {
        String ENTER_EMAIL_MESSAGE ="Please enter an email address";

        getHomePage().clickGiftCardPage();
        getGiftCardsPage().clickBirthdayCard();
        getGiftCardsPage().clickBirthdayCakeCard();
        getGiftCardsPage().clickCard25Usd();
        WebElement webElement = null;
        assertTrue(webElement.getText().contains(ENTER_EMAIL_MESSAGE));


    }

}
