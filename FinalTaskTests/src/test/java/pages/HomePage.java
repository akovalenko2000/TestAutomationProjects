package pages;

import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class HomePage extends BasePage {
    public HomePage(WebDriver driver){super(driver);}
    @FindBy(xpath = "//input[@id = 'twotabsearchtextbox']")
    private WebElement searchPanel;
    @FindBy(xpath = "//a[@id = 'nav-hamburger-menu']")
    private WebElement hamburgerCatalogue;
    @FindBy(xpath = "//div[contains(text(),'Kindle E-readers')]" )
    private WebElement kindleReaders;
    @FindBy(xpath = "//a[@href ='/dp/B00ZV9PXP2?ref_=nav_em__k_ods_eink_bn_0_2_6_3']" )
    private WebElement kindleBook;
    @FindBy(xpath = "//a[contains(@href,'gift-cards')]")
    private WebElement giftCardPage;
    @FindBy(xpath = "//select[@id='searchDropdownBox']")
    private WebElement departmentSearch;
    @FindBy(xpath = "//option[@value='search-alias=electronics-intl-ship']")
    private WebElement electronicsDepartment;
    @FindBy(xpath = "//div[@class='nav-right']//input[@class='nav-input']")
    private WebElement searchButton;
    @FindBy(xpath = "//a[@class = 'icp-button']")
    private WebElement changeCurrencyButton;
    @FindBy(xpath = "//span[@id='nav-cart-count']")
    private WebElement amountOfProductsInCart;






    public void searchByKeyword(final String keyword) {
        searchPanel.sendKeys(keyword, Keys.ENTER);
    }
    public void clickOnHamburgerCatalogue(){hamburgerCatalogue.click();}
    public void clickOnKindleReaders(){kindleReaders.click();}
    public void clickOnKindleBook(){kindleBook.click();}
    public void clickGiftCardPage(){giftCardPage.click();}
    public void clickDepartmentSearch(){departmentSearch.click();}
    public void clickElectronicsDepartment(){electronicsDepartment.click();}
    public void clickOnSearchButton(){searchButton.click();}
    public void clickChangeCurrencyButton(){changeCurrencyButton.click();}
    public String getTextOfAmountProductsInCart() {
        return amountOfProductsInCart.getText();
    }

}
