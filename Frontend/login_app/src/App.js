import React, { useState } from 'react';
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';
import Typography from '@mui/material/Typography';
import Button from './components/Button';

function App() {
    const [loginAttempts, setLoginAttempts] = useState([]);

    const handleLogin = (attempt) => {
        setLoginAttempts([...loginAttempts, attempt]);
    };

    const clearRecentAttempts = () => {
        setLoginAttempts([]);
    };

    return (
        <div className="App">
            <LoginForm onSubmit={handleLogin} />
            <div className="attempt-list-container">
                <Typography variant="h4" gutterBottom component="div">
                    Recent Attempts
                </Typography>
                <LoginAttemptList loginAttempts={loginAttempts} />
                {loginAttempts.length > 0 && (
                    <Button variant="outlined" color="error" onClick={clearRecentAttempts}>
                        Clear Recent Attempts
                    </Button>
                )}
            </div>
        </div>
    );
}

export default App;
