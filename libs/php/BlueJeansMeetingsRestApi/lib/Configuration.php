<?php
/**
 * Configuration
 * PHP version 5
 *
 * @category Class
 * @package  BlueJeansMeetingsRestApi
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BlueJeans Meetings REST API
 *
 * ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr>
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace BlueJeansMeetingsRestApi;

/**
 * Configuration Class Doc Comment
 * PHP version 5
 *
 * @category Class
 * @package  BlueJeansMeetingsRestApi
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class Configuration
{
    private static $defaultConfiguration;

    /**
     * Associate array to store API key(s)
     *
     * @var string[]
     */
    protected $apiKeys = [];

    /**
     * Associate array to store API prefix (e.g. Bearer)
     *
     * @var string[]
     */
    protected $apiKeyPrefixes = [];

    /**
     * Access token for OAuth
     *
     * @var string
     */
    protected $accessToken = '';

    /**
     * Username for HTTP basic authentication
     *
     * @var string
     */
    protected $username = '';

    /**
     * Password for HTTP basic authentication
     *
     * @var string
     */
    protected $password = '';

    /**
     * The default header(s)
     *
     * @var array
     */
    protected $defaultHeaders = [];

    /**
     * The host
     *
     * @var string
     */
    protected $host = 'https://api.bluejeans.com';

    /**
     * Timeout (second) of the HTTP request, by default set to 0, no timeout
     *
     * @var string
     */
    protected $curlTimeout = 0;

    /**
     * Timeout (second) of the HTTP connection, by default set to 0, no timeout
     *
     * @var string
     */
    protected $curlConnectTimeout = 0;

    /**
     * User agent of the HTTP request, set to "PHP-Swagger" by default
     *
     * @var string
     */
    protected $userAgent = 'Swagger-Codegen/1.0.0/php';

    /**
     * Debug switch (default set to false)
     *
     * @var bool
     */
    protected $debug = false;

    /**
     * Debug file location (log to STDOUT by default)
     *
     * @var string
     */
    protected $debugFile = 'php://output';

    /**
     * Debug file location (log to STDOUT by default)
     *
     * @var string
     */
    protected $tempFolderPath;

    /**
     * Indicates if SSL verification should be enabled or disabled.
     *
     * This is useful if the host uses a self-signed SSL certificate.
     *
     * @var boolean True if the certificate should be validated, false otherwise.
     */
    protected $sslVerification = true;

    /**
     * Curl proxy host
     *
     * @var string
     */
    protected $proxyHost;

    /**
     * Curl proxy port
     *
     * @var integer
     */
    protected $proxyPort;

    /**
     * Curl proxy type, e.g. CURLPROXY_HTTP or CURLPROXY_SOCKS5
     *
     * @see https://secure.php.net/manual/en/function.curl-setopt.php
     * @var integer
     */
    protected $proxyType;

    /**
     * Curl proxy username
     *
     * @var string
     */
    protected $proxyUser;

    /**
     * Curl proxy password
     *
     * @var string
     */
    protected $proxyPassword;

    /**
     * Allow Curl encoding header
     *
     * @var bool
     */
    protected $allowEncoding = false;

    /**
     * Constructor
     */
    public function __construct()
    {
        $this->tempFolderPath = sys_get_temp_dir();
    }

    /**
     * Sets API key
     *
     * @param string $apiKeyIdentifier API key identifier (authentication scheme)
     * @param string $key              API key or token
     *
     * @return $this
     */
    public function setApiKey($apiKeyIdentifier, $key)
    {
        $this->apiKeys[$apiKeyIdentifier] = $key;
        return $this;
    }

    /**
     * Gets API key
     *
     * @param string $apiKeyIdentifier API key identifier (authentication scheme)
     *
     * @return string API key or token
     */
    public function getApiKey($apiKeyIdentifier)
    {
        return isset($this->apiKeys[$apiKeyIdentifier]) ? $this->apiKeys[$apiKeyIdentifier] : null;
    }

    /**
     * Sets the prefix for API key (e.g. Bearer)
     *
     * @param string $apiKeyIdentifier API key identifier (authentication scheme)
     * @param string $prefix           API key prefix, e.g. Bearer
     *
     * @return $this
     */
    public function setApiKeyPrefix($apiKeyIdentifier, $prefix)
    {
        $this->apiKeyPrefixes[$apiKeyIdentifier] = $prefix;
        return $this;
    }

    /**
     * Gets API key prefix
     *
     * @param string $apiKeyIdentifier API key identifier (authentication scheme)
     *
     * @return string
     */
    public function getApiKeyPrefix($apiKeyIdentifier)
    {
        return isset($this->apiKeyPrefixes[$apiKeyIdentifier]) ? $this->apiKeyPrefixes[$apiKeyIdentifier] : null;
    }

    /**
     * Sets the access token for OAuth
     *
     * @param string $accessToken Token for OAuth
     *
     * @return $this
     */
    public function setAccessToken($accessToken)
    {
        $this->accessToken = $accessToken;
        return $this;
    }

    /**
     * Gets the access token for OAuth
     *
     * @return string Access token for OAuth
     */
    public function getAccessToken()
    {
        return $this->accessToken;
    }

    /**
     * Sets the username for HTTP basic authentication
     *
     * @param string $username Username for HTTP basic authentication
     *
     * @return $this
     */
    public function setUsername($username)
    {
        $this->username = $username;
        return $this;
    }

    /**
     * Gets the username for HTTP basic authentication
     *
     * @return string Username for HTTP basic authentication
     */
    public function getUsername()
    {
        return $this->username;
    }

    /**
     * Sets the password for HTTP basic authentication
     *
     * @param string $password Password for HTTP basic authentication
     *
     * @return $this
     */
    public function setPassword($password)
    {
        $this->password = $password;
        return $this;
    }

    /**
     * Gets the password for HTTP basic authentication
     *
     * @return string Password for HTTP basic authentication
     */
    public function getPassword()
    {
        return $this->password;
    }

    /**
     * Adds a default header
     *
     * @param string $headerName  header name (e.g. Token)
     * @param string $headerValue header value (e.g. 1z8wp3)
     *
     * @throws \InvalidArgumentException
     * @return $this
     */
    public function addDefaultHeader($headerName, $headerValue)
    {
        if (!is_string($headerName)) {
            throw new \InvalidArgumentException('Header name must be a string.');
        }

        $this->defaultHeaders[$headerName] =  $headerValue;
        return $this;
    }

    /**
     * Gets the default header
     *
     * @return array An array of default header(s)
     */
    public function getDefaultHeaders()
    {
        return $this->defaultHeaders;
    }

    /**
     * Deletes a default header
     *
     * @param string $headerName the header to delete
     *
     * @return $this
     */
    public function deleteDefaultHeader($headerName)
    {
        unset($this->defaultHeaders[$headerName]);
        return $this;
    }

    /**
     * Sets the host
     *
     * @param string $host Host
     *
     * @return $this
     */
    public function setHost($host)
    {
        $this->host = $host;
        return $this;
    }

    /**
     * Gets the host
     *
     * @return string Host
     */
    public function getHost()
    {
        return $this->host;
    }

    /**
     * Sets the user agent of the api client
     *
     * @param string $userAgent the user agent of the api client
     *
     * @throws \InvalidArgumentException
     * @return $this
     */
    public function setUserAgent($userAgent)
    {
        if (!is_string($userAgent)) {
            throw new \InvalidArgumentException('User-agent must be a string.');
        }

        $this->userAgent = $userAgent;
        return $this;
    }

    /**
     * Gets the user agent of the api client
     *
     * @return string user agent
     */
    public function getUserAgent()
    {
        return $this->userAgent;
    }

    /**
     * Sets the HTTP timeout value
     *
     * @param integer $seconds Number of seconds before timing out [set to 0 for no timeout]
     *
     * @throws \InvalidArgumentException
     * @return $this
     */
    public function setCurlTimeout($seconds)
    {
        if (!is_numeric($seconds) || $seconds < 0) {
            throw new \InvalidArgumentException('Timeout value must be numeric and a non-negative number.');
        }

        $this->curlTimeout = $seconds;
        return $this;
    }

    /**
     * Gets the HTTP timeout value
     *
     * @return string HTTP timeout value
     */
    public function getCurlTimeout()
    {
        return $this->curlTimeout;
    }

    /**
     * Sets the HTTP connect timeout value
     *
     * @param integer $seconds Number of seconds before connection times out [set to 0 for no timeout]
     *
     * @throws \InvalidArgumentException
     * @return $this
     */
    public function setCurlConnectTimeout($seconds)
    {
        if (!is_numeric($seconds) || $seconds < 0) {
            throw new \InvalidArgumentException('Connect timeout value must be numeric and a non-negative number.');
        }

        $this->curlConnectTimeout = $seconds;
        return $this;
    }

    /**
     * Set whether to accept encoding
     * @param bool $allowEncoding
     *
     * @return $this
     */
    public function setAllowEncoding($allowEncoding)
    {
        $this->allowEncoding = $allowEncoding;
        return $this;
    }

    /**
     * Gets the HTTP connect timeout value
     *
     * @return string HTTP connect timeout value
     */
    public function getCurlConnectTimeout()
    {
        return $this->curlConnectTimeout;
    }

    /**
     * Get whether to allow encoding
     *
     * @return bool
     */
    public function getAllowEncoding()
    {
        return $this->allowEncoding;
    }

    /**
     * Sets the HTTP Proxy Host
     *
     * @param string $proxyHost HTTP Proxy URL
     *
     * @return $this
     */
    public function setCurlProxyHost($proxyHost)
    {
        $this->proxyHost = $proxyHost;
        return $this;
    }

    /**
     * Gets the HTTP Proxy Host
     *
     * @return string
     */
    public function getCurlProxyHost()
    {
        return $this->proxyHost;
    }

    /**
     * Sets the HTTP Proxy Port
     *
     * @param integer $proxyPort HTTP Proxy Port
     *
     * @return $this
     */
    public function setCurlProxyPort($proxyPort)
    {
        $this->proxyPort = $proxyPort;
        return $this;
    }

    /**
     * Gets the HTTP Proxy Port
     *
     * @return integer
     */
    public function getCurlProxyPort()
    {
        return $this->proxyPort;
    }

    /**
     * Sets the HTTP Proxy Type
     *
     * @param integer $proxyType HTTP Proxy Type
     *
     * @return $this
     */
    public function setCurlProxyType($proxyType)
    {
        $this->proxyType = $proxyType;
        return $this;
    }

    /**
     * Gets the HTTP Proxy Type
     *
     * @return integer
     */
    public function getCurlProxyType()
    {
        return $this->proxyType;
    }

    /**
     * Sets the HTTP Proxy User
     *
     * @param string $proxyUser HTTP Proxy User
     *
     * @return $this
     */
    public function setCurlProxyUser($proxyUser)
    {
        $this->proxyUser = $proxyUser;
        return $this;
    }

    /**
     * Gets the HTTP Proxy User
     *
     * @return string
     */
    public function getCurlProxyUser()
    {
        return $this->proxyUser;
    }

    /**
     * Sets the HTTP Proxy Password
     *
     * @param string $proxyPassword HTTP Proxy Password
     *
     * @return $this
     */
    public function setCurlProxyPassword($proxyPassword)
    {
        $this->proxyPassword = $proxyPassword;
        return $this;
    }

    /**
     * Gets the HTTP Proxy Password
     *
     * @return string
     */
    public function getCurlProxyPassword()
    {
        return $this->proxyPassword;
    }

    /**
     * Sets debug flag
     *
     * @param bool $debug Debug flag
     *
     * @return $this
     */
    public function setDebug($debug)
    {
        $this->debug = $debug;
        return $this;
    }

    /**
     * Gets the debug flag
     *
     * @return bool
     */
    public function getDebug()
    {
        return $this->debug;
    }

    /**
     * Sets the debug file
     *
     * @param string $debugFile Debug file
     *
     * @return $this
     */
    public function setDebugFile($debugFile)
    {
        $this->debugFile = $debugFile;
        return $this;
    }

    /**
     * Gets the debug file
     *
     * @return string
     */
    public function getDebugFile()
    {
        return $this->debugFile;
    }

    /**
     * Sets the temp folder path
     *
     * @param string $tempFolderPath Temp folder path
     *
     * @return $this
     */
    public function setTempFolderPath($tempFolderPath)
    {
        $this->tempFolderPath = $tempFolderPath;
        return $this;
    }

    /**
     * Gets the temp folder path
     *
     * @return string Temp folder path
     */
    public function getTempFolderPath()
    {
        return $this->tempFolderPath;
    }

    /**
     * Sets if SSL verification should be enabled or disabled
     *
     * @param boolean $sslVerification True if the certificate should be validated, false otherwise
     *
     * @return $this
     */
    public function setSSLVerification($sslVerification)
    {
        $this->sslVerification = $sslVerification;
        return $this;
    }

    /**
     * Gets if SSL verification should be enabled or disabled
     *
     * @return boolean True if the certificate should be validated, false otherwise
     */
    public function getSSLVerification()
    {
        return $this->sslVerification;
    }

    /**
     * Gets the default configuration instance
     *
     * @return Configuration
     */
    public static function getDefaultConfiguration()
    {
        if (self::$defaultConfiguration === null) {
            self::$defaultConfiguration = new Configuration();
        }

        return self::$defaultConfiguration;
    }

    /**
     * Sets the detault configuration instance
     *
     * @param Configuration $config An instance of the Configuration Object
     *
     * @return void
     */
    public static function setDefaultConfiguration(Configuration $config)
    {
        self::$defaultConfiguration = $config;
    }

    /**
     * Gets the essential information for debugging
     *
     * @return string The report for debugging
     */
    public static function toDebugReport()
    {
        $report  = 'PHP SDK (BlueJeansMeetingsRestApi) Debug Report:' . PHP_EOL;
        $report .= '    OS: ' . php_uname() . PHP_EOL;
        $report .= '    PHP Version: ' . PHP_VERSION . PHP_EOL;
        $report .= '    OpenAPI Spec Version: 1.0.0' . PHP_EOL;
        $report .= '    Temp Folder Path: ' . self::getDefaultConfiguration()->getTempFolderPath() . PHP_EOL;

        return $report;
    }
}
