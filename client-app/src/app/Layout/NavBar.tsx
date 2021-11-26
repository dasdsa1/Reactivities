import React from 'react';
import { NavLink } from 'react-router-dom';
import { Button, Container, Menu } from 'semantic-ui-react';




export default function NavBar() {
    

    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item as={NavLink} exact to='/' header>
                    <img src="/assets/logo.png" alt="logo" style={{ marginRight: 10 }} />
                    Reactivities
                </Menu.Item>
                <Menu.Item as={NavLink} exact to='/Activities' name='Activities' />
                <Menu.Item>
                    <Button as={NavLink} exact to='/CreateActivity' positive content='Create Activity' />
                </Menu.Item>
            </Container>
            </Menu>
        )
}