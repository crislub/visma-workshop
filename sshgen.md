# Add ssh key

1. Create new ssh key in your laptop
```
ssh-keyge -t rsa -b 4096 -C "your_email@example.com"
```
<p align="center">
    <image src="image/ssh-keygen.png" width="50%" height="50%"/>
</p>

2.  After ssh key is created you have a public/private key pair. You need to copy content of your-key.pub.

<p align="center">
    <image src="image/ssh-output.png" width="50%" height="50%"/>
</p>

3. In github web page you need to go to uppper-right corner, click in your profile and then click Settings.

<p align="center">
    <image src="image/account-settings.png" width="20%" height="20%"/>
</p>

4. In the user settings sidebar, click SSH and GPG keys.

<p align="center">
    <image src="image/ssh-output.png" width="50%" height="50%"/>
</p>
![SSH key github](image/ssh-keys.png)

5. Click New SSH key.

<p align="center">
    <image src="image/ssh-output.png" width="50%" height="50%"/>
</p>

![New github key](image/new-ssh.png)

 6. In the "Title" field, add a descriptive label for the new key. Paste your key into the "Key" field.

<p align="center">
    <image src="image/ssh-output.png" width="50%" height="50%"/>
</p>

![Add ssh key](image/ssh-key-add.png)

7. Click Add ssh key.
8. You already have the ssh key. Now you need to go to Configure SSO.

<p align="center">
    <image src="image/ssh-output.png" width="50%" height="50%"/>
</p>

![SSO](image/ssh-configure-sso.png)

9. Press "Autorize" botom to allow you work with visma-raet organization.

<p align="center">
    <image src="image/ssh-output.png" width="50%" height="50%"/>
</p>

![SSO visma-raet](image/ssh-sso-visma.png)
