import React, { useState } from 'react';
import TextBox from './components/TextBox';
import Button from './components/Button';
import Typography from '@mui/material/Typography';
import './LoginForm.css';

const LoginForm = (props) => {
    const [login, setLogin] = useState('');
    const [password, setPassword] = useState('');
    const [loginError, setLoginError] = useState('');
    const [passwordError, setPasswordError] = useState('');

    const handleSubmit = (event) => {
        event.preventDefault();
        if (!login) {
            setLoginError("Please enter a username!");
            return;
        }
        if (!password) {
            setPasswordError("Please enter a password!");
            return;
        }
        if (password.length < 6) {
            setPasswordError("Password should be at least 6 characters long!");
            return;
        }
        setLoginError('');
        setPasswordError('');
        props.onSubmit({ login, password });
    }

    return (
        <div className="login-container">
            <form className="form" onSubmit={handleSubmit}>
                <Typography variant="h4" gutterBottom component="div">
                    Login
                </Typography>
                <div className="form-group">
                    <TextBox label="Name" id="name" value={login} size="small" onChange={(e) => setLogin(e.target.value)} />
                    {loginError && <div className="error-message">{loginError}</div>}
                </div>
                <div className="form-group">
                    <TextBox label="Password" type="password" id="password" value={password} size="small" onChange={(e) => setPassword(e.target.value)} />
                    {passwordError && <div className="error-message">{passwordError}</div>}
                </div>
                <div className="form-group">
                    <Button type="submit">
                        Continue
                    </Button>
                </div>
            </form>
        </div>
    );
};

export default LoginForm;
