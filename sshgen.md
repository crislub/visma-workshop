    - Create new ssh key in your laptop
```
ssh-keyge -t rsa -b 4096 -C "your_email@example.com"
```
![SSH keygen](image/ssh-keygen.png)
    - After ssh key is created you have a public/private key pair. You need to copy content of your-key.pub.
![SSH output](image/ssh-output.png)
    - In github web page you need to go to uppper-right corner, click in your profile and then click Settings.
![Account Settings](image/account-settings.png)
    - In the user settings sidebar, click SSH and GPG keys.
![SSH key github](image/ssh-keys.png)
    - Click New SSH key.
![New github key](image/new-ssh.png)
    - In the "Title" field, add a descriptive label for the new key. Paste your key into the "Key" field.
![Add ssh key](image/ssh-key-add.png)
    - Click Add ssh key.
    - You already have the ssh key. Now you need to go to Configure SSO.
![SSO](image/ssh-configure-sso.png)
    - Press "Autorize" botom to allow you work with visma-raet organization.
![SSO visma-raet](image/ssh-sso-visma.png)
