import Link from 'next/link';

const Home = () => {
  return (
    <main>
      <h1>Welcome to My App</h1>
      <Link href="/login">
        <a>Login</a>
      </Link>
    </main>
  );
};

export default Home;