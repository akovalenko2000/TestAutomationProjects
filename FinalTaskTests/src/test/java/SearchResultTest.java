import org.openqa.selenium.WebElement;
import org.testng.annotations.Test;

import static org.testng.Assert.assertEquals;
import static org.testng.Assert.assertTrue;

public class SearchResultTest extends BaseStepsTest{
    private String SEARCH_KEYWORD = "Amazon Kindle";
    private String EXPECTED_SEARCH_QUERY = "s?k=Amazon+Kindle";
    private int EXPECTED_NUMBER_OF_PRODUCTS_ON_SEARCH_PAGE = 12;

    @Test
    public void checkThatUrlContainsSearchWord() {
        getHomePage().searchByKeyword(SEARCH_KEYWORD);
        assertTrue(getDriver().getCurrentUrl().contains(EXPECTED_SEARCH_QUERY));
    }

    @Test
    public void checkElementsAmountOnSearchPage() {
        getHomePage().searchByKeyword(SEARCH_KEYWORD);
        getBasePage().implicitWait(30);
        assertEquals(getSearchResultsPage().getSearchResultsCount(), EXPECTED_NUMBER_OF_PRODUCTS_ON_SEARCH_PAGE);
    }

    @Test
    public void checkThatSearchResultsContainsSearchWord() {
        getHomePage().searchByKeyword(SEARCH_KEYWORD);
        for (WebElement webElement : getSearchResultsPage().getSearchResultsList()) {
            assertTrue(webElement.getText().contains(SEARCH_KEYWORD));
        }
    }



}
