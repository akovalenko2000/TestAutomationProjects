import org.testng.annotations.Test;

import static org.testng.Assert.assertEquals;

public class CartSettingsTests extends BaseStepsTest{
    private String EXPECTED_ONE_PRODUCT_IN_CART = "1";
    private String EXPECTED_NULL_PRODUCTS_IN_CART = null;
    @Test
    public void checkSaveForLaterButton(){
        getCartPage().clickSaveForLaterIpad();
        assertEquals(getHomePage().getTextOfAmountProductsInCart(), EXPECTED_ONE_PRODUCT_IN_CART);

    }
    @Test
    public void checkDeleteFromCartButton(){
        getCartPage().clickDeleteWhiteReaderFromCart();
        assertEquals(getHomePage().getTextOfAmountProductsInCart(), EXPECTED_NULL_PRODUCTS_IN_CART);

    }


}
