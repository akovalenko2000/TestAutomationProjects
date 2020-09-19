import org.testng.annotations.Test;

import static org.testng.Assert.assertEquals;

public class AddToCartTest extends BaseStepsTest{
    private String EXPECTED_ONE_PRODUCT_IN_CART = "1";
    private String EXPECTED_TWO_PRODUCTS_IN_CART = "2";

    @Test
    public void checkAddToCartViaCatalogue() {
        getHomePage().clickOnHamburgerCatalogue();
        getHomePage().clickOnKindleReaders();
        getHomePage().clickOnKindleBook();
        getBasePage().waitForPageLoadComplete(30);
        getKindlePage().clickOnWhitColourBook();
        getKindlePage().clickAddToCart();
        assertEquals(getHomePage().getTextOfAmountProductsInCart(), EXPECTED_ONE_PRODUCT_IN_CART);
    }
    @Test
    public void checkAddToCartViaSearchDepartment(){
        getHomePage().clickDepartmentSearch();
        getHomePage().clickElectronicsDepartment();
        getHomePage().clickOnSearchButton();
        getElectronicsPage().ClickOnIpad();
        getIpadPage().clickAddToCartButton();
        assertEquals(getHomePage().getTextOfAmountProductsInCart(), EXPECTED_TWO_PRODUCTS_IN_CART);
    }


}
