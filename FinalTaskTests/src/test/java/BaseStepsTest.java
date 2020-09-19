import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.BeforeTest;
import pages.*;

public class BaseStepsTest {
    private WebDriver driver;
    private static final String AMAZON_URL = "https://www.amazon.com/";


    @BeforeTest
    public void profileSetUp() {
        System.setProperty("webdriver.chrome.driver", "src\\main\\resources\\chromedriver.exe");
    }

    @BeforeMethod
    public void testsSetUp() {
        driver = new ChromeDriver();
        driver.manage().window().maximize();
        driver.get(AMAZON_URL);
    }

    @AfterMethod
    public void tearDown() {
        driver.close();
    }
    public WebDriver getDriver() {
        return driver;
    }

    public BasePage getBasePage() {
        return new BasePage(getDriver());
    }

    public HomePage getHomePage() {
        return new HomePage(getDriver());
    }

    public SearchResultPage getSearchResultsPage() {
        return new SearchResultPage(getDriver());
    }

    public CartPage getCartPage(){return new CartPage(getDriver());}

    public ChangeCurrencyPage getChangeCurrencyPage(){return new ChangeCurrencyPage(getDriver());}

    public ElectronicsPage getElectronicsPage() {
        return new ElectronicsPage(getDriver());
    }

    public GiftCardsPage getGiftCardsPage() {
        return new GiftCardsPage(getDriver());
    }

    public IpadPage getIpadPage() {
        return new IpadPage(getDriver());
    }

    public KindlePage getKindlePage() { return new KindlePage(getDriver()); }
}
