import React, { useState } from 'react';
import TextBox from './components/TextBox';
import Button from './components/Button';
import Typography from '@mui/material/Typography';
import './LoginForm.css';

const LoginForm = (props) => {
    const [login, setLogin] = useState('');
    const [password, setPassword] = useState('');

    const handleSubmit = (event) => {
        event.preventDefault();
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
                </div>
                <div className="form-group">
                    <TextBox label="Password" type="password" id="password" value={password} size="small" onChange={(e) => setPassword(e.target.value)} />
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
