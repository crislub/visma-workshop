#Add ssh key

1. Create new ssh key in your laptop
```
ssh-keyge -t rsa -b 4096 -C "your_email@example.com"
```

![SSH keygen](image/ssh-keygen.png)

2.  After ssh key is created you have a public/private key pair. You need to copy content of your-key.pub.

![SSH output](image/ssh-output.png)

3. In github web page you need to go to uppper-right corner, click in your profile and then click Settings.

![Account Settings](image/account-settings.png)

4. In the user settings sidebar, click SSH and GPG keys.

![SSH key github](image/ssh-keys.png)

5. Click New SSH key.

![New github key](image/new-ssh.png)

 6. In the "Title" field, add a descriptive label for the new key. Paste your key into the "Key" field.

![Add ssh key](image/ssh-key-add.png)

7. Click Add ssh key.
8. You already have the ssh key. Now you need to go to Configure SSO.

![SSO](image/ssh-configure-sso.png)

9. Press "Autorize" botom to allow you work with visma-raet organization.

![SSO visma-raet](image/ssh-sso-visma.png)
